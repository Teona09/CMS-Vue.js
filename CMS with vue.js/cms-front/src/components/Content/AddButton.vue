<template>
  <section class="addSection">
    <button id="addWithModal" @click="showDialog()">Add record</button>
    <!-- The Modal -->
    <add-modal :open="dialogIsVisible" class="input-form" @close="hideDialog()">
      <button id="close" @click="hideDialog()">&times;</button>
    </add-modal>
  </section>
</template>

<script>
import AddModal from "./Modals/AddModal.vue";
export default {
  components: {
    AddModal,
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

#addWithModal {
  position: fixed;
  top: 7rem;
  color: var(--pastel-yellow);
  padding: 0.125rem;
  width: 10%;
  min-width: 5rem;
  font-size: 1.125rem;
  background-color: var(--orange);
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
</style>
