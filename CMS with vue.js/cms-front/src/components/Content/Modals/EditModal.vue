<template>
  <div v-if="open" class="backdrop" @click="$emit('close')"></div>
  <transition name="edit-modal">
    <dialog open v-if="open">
      <slot></slot>
      <div class="input-data">
        <label for="fname">First name: </label>
        <input
          v-model="fname"
          type="search"
          class="search-bar"
          placeholder="fname"
          id="fname"
          required
        />
      </div>
      <div class="input-data">
        <label for="lname">Last name: </label>
        <input
          v-model="lname"
          type="search"
          class="search-bar"
          placeholder="lname"
          id="lname"
          required
        />
      </div>
      <div class="input-data">
        <label for="email">Email: </label>
        <input
          v-model="email"
          type="search"
          class="search-bar"
          placeholder="email"
          id="email"
          required
        />
      </div>
      <div class="input-data">
        <label for="gender">Gender: </label>
        <select v-model="gender" placeholder="gender" id="gender" required>
          <option value="1">male</option>
          <option value="2">female</option>
          <option value="3">ninja</option>
          <option value="4">robot</option>
          <option value="5">pirate</option>
          <option value="0">other</option>
        </select>
      </div>
      <div class="input-data">
        <label for="birthdate">Birthdate: </label>
        <input
          v-model="birthdate"
          type="date"
          placeholder="birthdate"
          id="birthdate"
          required
        />
      </div>
      <div class="input-data">
        <label for="photo">Photo: </label>
        <input type="file" @change="previewImage" accept="image/*" />
        <div class="image-preview" v-if="photoSrc.length > 0">
          <img class="preview" :src="photoSrc" height="30" />
        </div>
        <div class="image-preview" v-else>
          <img class="preview" :src="placeholderImg" height="30" />
        </div>
      </div>
      <br />
      <button id="submit" @click="submitData()">Submit</button>
    </dialog>
  </transition>
</template>

<script>
import moment from "moment";
import variables from "../../../variables";
import axios from "axios";
export default {
  props: ["open", "idEmp"],
  emits: ["close"],
  data() {
    return {
      id: "",
      fname: "",
      lname: "",
      email: "",
      gender: "",
      birthdate: "",
      photoSrc: "",
      file: "",
      placeholderImg: variables.DEFAULT_IMAGE_BASE64,
      putAPI: variables.PUT_BY_ID_API,
      getbyIdAPI: variables.GET_BY_ID_API,
    };
  },
  methods: {
    moment: moment,
    submitData() {
      if (this.checkInput()) {
        axios
          .put(this.putAPI + this.id, {
            firstName: this.fname,
            lastName: this.lname,
            email: this.email,
            gender: this.gender,
            birthdate: this.birthdate,
            photoSrc: this.photoSrc,
          })
          .then(() => {
            this.$emit("close");
            this.$emit("edit-completed");
          });
      }
    },
    previewImage: function(event) {
      var input = event.target;
      var reader = new FileReader();
      if (input.files && input.files[0]) {
        reader.onload = (e) => {
          this.photoSrc = e.target.result;
        };
        reader.readAsDataURL(input.files[0]);
      }
    },
    validateEmail(email) {
      var re = /\S+@\S+\.\S+/;
      return re.test(email);
    },
    calculateAge() {
      var today = new Date();
      var birthdate = new Date(this.birthdate);
      var age = today.getFullYear() - birthdate.getFullYear();
      var month = today.getMonth() - birthdate.getMonth();
      if (month < 0 || (month === 0 && today.getDate() < birthdate.getDate())) {
        age--;
      }
      return age;
    },
    checkInput() {
      var errors = "";
      if (this.fname === "") {
        errors += "First Name Can't Be Empty.\n";
      }
      if (this.lname === "") {
        errors += "Last Name Can't Be Empty.\n";
      }
      if (this.email === "") {
        errors += "Email Can't Be Empty.\n";
      } else if (!this.validateEmail(this.email)) {
        errors += "Email is not valid\n";
      }
      if (this.gender === "") {
        errors += "Gender Can't Be Empty.\n";
      }
      if (this.birthdate === "") {
        errors += "Birthdate Can't Be Empty.\n";
      } else if (this.calculateAge() < 16) {
        errors += "Age sould be above 16.\n";
      }
      if (errors.length === 0) return true;
      alert(errors);
      return false;
    },
    loadData() {
      axios
        .get(this.getbyIdAPI + this.idEmp)
        .then((response) => {
          if (response.status) {
            return response.data;
          }
        })
        .then((data) => {
          this.id = data.id;
          this.fname = data.firstName;
          this.lname = data.lastName;
          this.email = data.email;
          this.gender = data.gender;
          this.birthdate = data.birthdate;
          this.photoSrc = data.photoSrc;
        })
        .catch((error) => {
          console.log(error);
        });
    },
  },
  mounted() {
    this.loadData();
  },
};
</script>

<style scoped>
.backdrop {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100vh;
  z-index: 10;
  background-color: rgba(0, 0, 0, 0.75);
}

dialog {
  position: fixed;
  top: 30vh;
  width: 30rem;
  left: calc(50% - 15rem);
  margin: 0;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.26);
  border-radius: 12px;
  padding: 1rem;
  z-index: 100;
  border: none;
  background-color: rgba(0, 0, 0, 0.4);
  background-color: var(--pastel-light-green);
}

.edit-modal-enter-active {
  animation: modal 0.3s ease-out;
}

.edit-modal-leave-active {
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

/* Modal Content */
/*.input-form {
  z-index: 1;
  left: 50;
  top: 50;
  width: 80%;
  height: 80%;
  margin: auto;
  padding: 20px;
}
*/
.input-data {
  padding: 1rem;
}

.input-data .search-bar {
  background: white;
  border: black;
  text-align: center;
  border-radius: 30px;
  width: 80%;
  height: 70%;
}

#submit {
  color: var(--pastel-yellow);
  background-color: var(--orange);
  font-size: 120%;
  padding: 0.225rem;
  display: flex;
  justify-content: center;
}

#submit:hover {
  color: #000;
  text-decoration: none;
  cursor: pointer;
}
</style>
