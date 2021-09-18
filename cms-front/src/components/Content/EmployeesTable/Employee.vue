<template>
  <tr>
    <td>{{ photoSrc }}</td>
    <td>{{ fname }}</td>
    <td>{{ lname }}</td>
    <td>{{ email }}</td>
    <td>{{ gender }}</td>
    <td>{{ birthdate }}</td>
    <td>
      <button>
        Edit
      </button>
      <button>
        Delete
      </button>
    </td>
  </tr>
</template>

<script>
export default {
  props: ["fname", "lname", "email", "gender", "birthdate", "photoSrc"],
};
</script>

<style></style>
