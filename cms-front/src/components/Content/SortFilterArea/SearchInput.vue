<template
  ><div class="search-input">
    <input type="text" title="Search employee by name" id="search-bar" />
    <span id="search-icon">
      <i class="fas fa-search"></i>
    </span>
  </div>
</template>

<script>
export default {};
</script>

<style>
.search-input {
  height: 1.5rem;
  padding: 1rem;
}

.search-input #search-bar {
  position: relative;
  background: white;
  text-align: center;
  border-radius: 30px;
  border: 1px solid;
  width: 15rem;
  height: 1.5rem;
}

#search-bar:focus {
  outline: none;
}

#search-icon {
  position: relative;
  left: -9%;
  top: 10%;
}
</style>
