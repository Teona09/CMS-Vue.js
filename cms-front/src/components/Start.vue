<template>
  <h2>get employee by id</h2>
  <ul>
    <employee
      v-for="result in results"
      :key="result.id"
      :fname="result.fname"
      :lname="result.lname"
      :email="result.email"
      :birthdate="result.birthdate"
      :photoSrc="result.photoSrc"
    ></employee>
  </ul>
</template>

<script>
import axios from "axios";
import Employee from "./Employee.vue";
export default {
  name: "App",
  components: { Employee },
  data() {
    return {
      results: [],
    };
  },
  methods: {
    loadData() {
      console.log("help");
      axios
        .get("https://localhost:5001/api/Employees/get-all-employees")
        .then((response) => {
          if (response.status) {
            console.log(response);
            return response.data;
          }
        })
        .then((data) => {
          const results = [];
          for (const id in data) {
            results.push({
              id: id,
              fname: data[id].firstName,
              lname: data[id].lastName,
              email: data[id].email,
              birthdate: data[id].birthdate,
              photoSrc: data[id].photoSrc,
            });
          }
          this.results = results;
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

<style></style>
