<template>
  <div class="content">
    <!-- Add Button -->
    <!-- Sort-Filter-Area -->
    <!-- Employees-Table-->
    <employees-table></employees-table>
  </div>
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

<style>
.content {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  height: 95%;
  padding: 0.625rem 0.625rem;
  background-color: var(--pastel-yellow);
}
</style>
