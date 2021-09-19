<template>
  <div class="sort-filter-area">
    <!-- SearchInput -->
    <search-input></search-input>
    <!-- SortArea -->
    <sort-area></sort-area>
    <!-- FilterArea -->
    <filter-area></filter-area>
  </div>
</template>

<script>
import SearchInput from "./SearchInput.vue";
import SortArea from "./SortArea.vue";
import FilterArea from "./FilterArea.vue";
export default {
  components: {
    SearchInput,
    SortArea,
    FilterArea,
  },
};
</script>

<style>
.sort-filter-area {
  position: fixed;
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  padding-top: 0.1rem;
  padding-left: 1.5rem;
  padding-right: 1.5rem;
  padding-bottom: 0.1rem;
  width: 70%;
  height: 8rem;
  top: 10rem;
}
</style>
