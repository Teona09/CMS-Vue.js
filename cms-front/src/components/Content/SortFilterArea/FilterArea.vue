<template>
  <div class="filter-area">
    <div class="filter-select">
      <label id="filter-label" for="filter">filter by:</label>
      <select id="filter-list">
        <option value=" ">None</option>
        <option value=" ">Has Photo</option>
        <option value=" ">No Photo</option>
      </select>
    </div>
  </div>
</template>

<script>
export default {
  name: "App",
};
</script>

<style>
.filter-area {
  height: 1.5rem;
  padding: 1rem;
}

.filter-select {
  position: relative;
  display: flex;
  flex-direction: row;
  border-radius: 30px;
  height: 1.5rem;
}

#filter-label {
  padding-right: 1rem;
  white-space: nowrap;
  font-size: larger;
}
</style>
