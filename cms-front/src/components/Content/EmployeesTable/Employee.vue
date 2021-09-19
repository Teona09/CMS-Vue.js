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
      <button class="icons" id="edit-icon">
        <i class="fas fa-pen-square"></i>
      </button>
      <button class="icons" id="delete-icon" @click="removeEmployee(this.id)">
        <i class="fas fa-times fa"></i>
      </button>
    </td>
  </tr>
</template>

<script>
import axios from "axios";

export default {
  props: ["id", "fname", "lname", "email", "gender", "birthdate", "photoSrc"],
  methods: {
    removeEmployee(id) {
      console.log(id);
      if (!confirm("Are you sure you want to delete this employee?")) {
        return;
      }
      console.log(id);
      // axios delete-by-id
      axios
        .delete(
          "https://localhost:5001/api/Employees/delete-employee-by-id/" + id
        )
        .then((response) => {
          alert("refresh the page");
          console.log(response.data);
        });
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
</style>
