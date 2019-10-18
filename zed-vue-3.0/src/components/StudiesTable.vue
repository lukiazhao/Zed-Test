<template>
    <div class="mt-5">
        <b-table
        id="studies_table"
        :items= "studies"
        :fields="fields"
        :current-page="currentPage"
        :per-page="perPage"
        stacked="md"
        striped hover
        empty-filtered-text="No matching record"
        responsive="sm"
        >
        <!-- show study details  -->
        <template v-slot:cell(actions)="row">
            <b-button size="sm" @click="row.toggleDetails" class="mr-2 detail_btn">
                {{ row.detailsShowing ? 'Hide' : 'Show'}} Details
            </b-button>
        </template>

        <!-- Details in card -->
        <template v-slot:row-details="row">
            <StudyCard :study="row.item"></StudyCard>
        </template>
        </b-table>
        
        <!-- Pagination -->
        <b-row class="justify-content-md-center mb-2">
            <b-pagination
            v-model="currentPage"
            :total-rows="totalRows"
            :per-page="perPage"
            size="md"
            aria-controls="studies_table"
            ></b-pagination>
        </b-row>
    </div>
</template>

<script>
import StudyCard from '@/components/StudyCard'

export default {
    name: 'StudiesTable',
    components: {
        StudyCard
    },
    props: {
        studies: Array
    },
    data() {
        return {
            /* Fields displayed in table */
            fields: [
                { key: 'guid', label: 'GUID', sortable: true },
                { key: 'patientsName', label: 'Patient Name', sortable: true },
                { key: 'studyDescription', label: 'Study Description'},
                { key: 'studyDate', label: 'Study Date', sortable: true },
                { key: 'actions', label: 'Actions' }
            ], 
            totalRows: 1,
            currentPage: 1,
            perPage: 5,
        }
    },
    mounted() {
        this.totalRows = this.studies.length;
    }
}
</script>

<style>
th {
    background-color:#4682B4	;
    color: #ffffff
}
.table-hover>tbody>tr:hover {
    background-color: #D4DEE5;
}
</style>