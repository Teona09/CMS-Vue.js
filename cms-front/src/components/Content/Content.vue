<template>
  <!-- Add Button -->
  <!-- Sort-Filter-Area -->
  <!-- Employees-Table-->
  <employees-table></employees-table>
</template>

<script>
import EmployeesTable from "./EmployeesTable/EmployeesTable.vue";

export default {
  name: "App",
  components: {
    EmployeesTable,
  },
};
</script>

<style></style>
