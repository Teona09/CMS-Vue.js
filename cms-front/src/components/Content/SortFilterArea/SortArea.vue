<template>
  <div class="sort-area">
    <div class="sort-select">
      <label id="sort-label" for="sort">Sort by:</label>
      <select id="sort-list">
        <option value=" ">None</option>
        <option value="asc-alphabetically"
          >Ascending alphabetically after first name</option
        >
        <option value="desc-alphabetically"
          >Descending alphabetically after first name</option
        >
        <option value="asc-birthdate">Ascending after birthdate</option>
        <option value="desc-birthdate">Descending after birthdate</option>
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
.sort-area {
  height: 1.5rem;
  padding: 1rem;
}

.sort-select {
  position: relative;
  display: flex;
  flex-direction: row;
  border-radius: 30px;
  height: 1.5rem;
}

#sort-label {
  padding-right: 1rem;
  white-space: nowrap;
  font-size: larger;
}
</style>
