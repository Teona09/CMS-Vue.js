<template>
  <tr>
    <td>
      <img v-bind:src="photoSrc" alt="profileImage" height="40" />
    </td>
    <td>{{ fname }}</td>
    <td>{{ lname }}</td>
    <td>{{ email }}</td>
    <td>{{ gender }}</td>
    <td>{{ birthdate }}</td>
    <td class="actions">
      <edit-button :idEmp="this.id" @edit-completed="passMessage">
      </edit-button>
      <button class="icons" id="delete-icon" @click="removeEmployee(this.id)">
        <i class="fas fa-times fa"></i>
      </button>
    </td>
  </tr>
</template>

<script>
import axios from "axios";
import variables from "../../../variables";
import EditButton from "./EditButton.vue";

export default {
  props: ["id", "fname", "lname", "email", "gender", "birthdate", "photoSrc"],
  components: {
    EditButton,
  },
  data() {
    return {
      deleteAPI: variables.DELETE_BY_ID_API,
    };
  },
  methods: {
    removeEmployee(id) {
      if (!confirm("Are you sure you want to delete this employee?")) {
        return;
      }
      axios.delete(this.deleteAPI + id).then(() => {
        this.$emit("actions-on-employee");
      });
    },
    passMessage() {
      this.$emit("actions-on-employee");
    },
  },
};
</script>

<style>
td {
  border-width: 0.025rem;
  border-color: black;
  border-style: solid;
  border-collapse: collapse;
  font-size: 1.125rem;
  padding: 0.625rem 0.625rem;
  background-color: var(--pastel-light-green);
  color: var(--orange);
}

.actions {
  padding: 0.1rem 0.1rem 0.1rem 1.5rem;
}

.icons {
  width: 2rem;
  height: 2rem;
  background: none;
  border: none;
  font-size: 2rem;
}

#edit-icon {
  color: black;
}

#delete-icon {
  color: red;
}

@media (max-width: 1120px) {
  td {
    font-size: 0.875rem;
  }

  .icons {
    padding: 0.05rem;
    width: 1.75rem;
    font-size: 1.75rem;
  }
}

@media (max-width: 800px) {
  td {
    font-size: 0.75rem;
  }

  .icons {
    padding: 0.05rem;
    width: 1.25rem;
    font-size: 1.25rem;
  }
}
</style>
