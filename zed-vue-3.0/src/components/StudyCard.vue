<template>
    <b-card>
        <b-row class="justify-content-md-center">
            <table>
                <tbody>
                    <tr v-for="(value, key) in study" :key="key">
                        <th>{{ key }}</th>
                        <th>{{ value }}</th>
                    </tr>
                </tbody>
            </table>
        </b-row>
    </b-card>
</template>

<script>
export default {
    name: 'StudyCard',
    props: {
        study: Object
    }
}
</script>

<style scoped>
    th {
      text-align: left;
      border: 1px solid white;
      background-color: #578ebb;
    }
</style>

