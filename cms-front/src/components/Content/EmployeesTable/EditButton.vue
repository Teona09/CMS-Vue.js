<template>
  <button @click="showDialog" class="icons" id="edit-icon">
    <i class="fas fa-pen-square"></i>
  </button>
  <!-- The Modal -->
  <edit-modal
    :open="dialogIsVisible"
    :idEmp="idEmp"
    class="input-form"
    @close="hideDialog()"
    @edit-completed="passMessage"
  >
    <button id="close" @click="hideDialog()">&times;</button>
  </edit-modal>
</template>

<script>
import EditModal from "../Modals/EditModal.vue";
export default {
  props: ["idEmp"],
  components: {
    EditModal,
  },
  data() {
    return {
      dialogIsVisible: false,
    };
  },
  methods: {
    showDialog() {
      this.dialogIsVisible = true;
    },
    hideDialog() {
      this.dialogIsVisible = false;
    },
    passMessage() {
      this.$emit("edit-completed");
    },
  },
};
</script>

<style>
.modal-enter-active {
  animation: modal 0.3s ease-out;
}

.modal-leave-active {
  animation: modal 0.3s ease-in reverse;
}

@keyframes modal {
  from {
    opacity: 0;
    transform: translateY(-50px) scale(0.9);
  }

  to {
    opacity: 1;
    transform: translateY(0) scale(1);
  }
}

.addSection {
  display: flex;
  justify-content: center;
  align-items: center;
}

.input-form {
  z-index: 1;
  left: 50;
  top: 50;
  width: 80%;
  height: 80%;
  margin: auto;
  padding: 20px;
}

#close {
  color: rgb(92, 0, 0);
  float: right;
  font-size: 30px;
  font-weight: bold;
  border: none;
  background: none;
}

#close:hover,
#close:focus {
  color: var(--orange);
  text-decoration: none;
  cursor: pointer;
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

@media (max-width: 1120px) {
  .icons {
    padding: 0.05rem;
    width: 1.75rem;
    font-size: 1.75rem;
  }
}

@media (max-width: 800px) {
  .icons {
    padding: 0.05rem;
    width: 1.25rem;
    font-size: 1.25rem;
  }
}
</style>
