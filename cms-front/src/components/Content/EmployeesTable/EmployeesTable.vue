<template>
  <table id="employees-table">
    <caption>
      Employees List
    </caption>
    <tr>
      <th>Photo</th>
      <th>First name</th>
      <th>Last name</th>
      <th>Email</th>
      <th>Gender</th>
      <th>Birthdate</th>
      <th>Actions</th>
    </tr>
    <employee
      v-for="result in results"
      :key="result.id"
      :fname="result.fname"
      :lname="result.lname"
      :email="result.email"
      :birthdate="result.birthdate"
      :photoSrc="result.photoSrc"
    ></employee>
  </table>
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

<style>
#employees-table {
  width: 62.5em;
  text-align: left;
  position: fixed;
  top: 15rem;
}

#employees-table caption {
  font-size: 1.5rem;
  padding: 0.625rem 0.625rem;
  color: var(--orange);
  font-style: italic;
}

#employees-table th {
  text-align: left;
}

#employees-table,
th,
td {
  border-width: 0.025rem;
  border-color: black;
  border-style: solid;
  border-collapse: collapse;
  font-size: 1.125rem;
}

th,
td {
  padding: 0.625rem 0.625rem;
  background-color: var(--pastel-light-green);
  color: var(--orange);
}
</style>
