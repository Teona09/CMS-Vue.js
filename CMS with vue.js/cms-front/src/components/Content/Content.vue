<template>
  <section class="content">
    <!-- Add Button -->
    <add-button></add-button>
    <!-- Sort-Filter-Area -->
    <sort-filter-area></sort-filter-area>
    <!-- Employees-Table-->
    <employees-table></employees-table>
  </section>
</template>

<script>
import AddButton from "./AddButton.vue";
import SortFilterArea from "./SortFilterArea/SortFilterArea.vue";
import EmployeesTable from "./EmployeesTable/EmployeesTable.vue";

export default {
  name: "App",
  components: {
    AddButton,
    SortFilterArea,
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
