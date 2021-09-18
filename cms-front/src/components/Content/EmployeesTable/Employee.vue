<template>
  <tr>
    <td>{{ photoSrc }}</td>
    <td>{{ fname }}</td>
    <td>{{ lname }}</td>
    <td>{{ email }}</td>
    <td>{{ gender }}</td>
    <td>{{ birthdate }}</td>
    <td>{{ actions }}</td>
  </tr>
</template>

<script>
export default {
  props: [
    "fname",
    "lname",
    "email",
    "gender",
    "birthdate",
    "photoSrc",
    "actions",
  ],
};
</script>

<style></style>
