<script setup lang="ts">
interface IUser {
  name: string;
  email: string;
}

const user: IUser = {
  name: "Cesare",
  email: "cesare.caoduro@aecom.com",
};

console.log(user);
</script>
<template>
  <div>Hello from Nuxt</div>
</template>
