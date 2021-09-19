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
      :id="result.id"
      :fname="result.fname"
      :lname="result.lname"
      :email="result.email"
      :gender="result.gender"
      :birthdate="result.birthdate"
      :photoSrc="result.photoSrc"
    ></employee>
  </table>
</template>

<script>
import axios from "axios";
import moment from "moment";
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
    moment: moment,
    convertGenderFromIntToString(number) {
      switch (number) {
        /* 0 - Other
         * 1 - Male
         * 2 - Female
         * 3 - Ninja
         * 4 - Robot
         * 5 - Pirate
         */
        case 0: {
          return "Other";
        }
        case 1: {
          return "Male";
        }
        case 2: {
          return "Female";
        }
        case 3: {
          return "Ninja";
        }
        case 4: {
          return "Robot";
        }
        case 5: {
          return "Pirate";
        }
      }
    },
    convertTimestampToDate(timestamp) {
      var birthdate = moment(timestamp);
      return birthdate.format("DD MMM YYYY");
    },
    loadData() {
      axios
        .get("https://localhost:5001/api/Employees/get-all-employees")
        .then((response) => {
          if (response.status) {
            return response.data;
          }
        })
        .then((data) => {
          const results = [];
          for (const id in data) {
            results.push({
              id: data[id].id,
              fname: data[id].firstName,
              lname: data[id].lastName,
              email: data[id].email,
              gender: this.convertGenderFromIntToString(data[id].gender),
              birthdate: this.convertTimestampToDate(data[id].birthdate),
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
  top: 20rem;
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
th {
  border-width: 0.025rem;
  border-color: black;
  border-style: solid;
  border-collapse: collapse;
  font-size: 1.125rem;
  padding: 0.625rem 0.625rem;
  background-color: var(--pastel-light-green);
  color: var(--orange);
}

@media (max-width: 1120px) {
  #employees-table {
    width: 45em;
  }
  #employees-table caption {
    font-size: 1.125rem;
    padding: 0.45rem 0.45rem;
  }

  th {
    text-align: left;
    font-size: 0.875rem;
  }

  @media (max-width: 800px) {
    #employees-table {
      width: 35em;
    }
    #employees-table caption {
      font-size: 1rem;
      padding: 0.45rem 0.45rem;
    }
    th {
      font-size: 0.75rem;
    }
  }
}
</style>
