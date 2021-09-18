<template>
  <li>
    <p>{{ fname }} {{ lname }} {{ email }} {{ birthdate }} {{ photoSrc }}</p>
  </li>
</template>

<script>
export default {
  props: ["fname", "lname", "email", "birthdate", "photoSrc"],
};
</script>

<style></style>
