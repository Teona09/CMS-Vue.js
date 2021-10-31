import { createApp } from "vue";
import Employee from "./components/Content/EmployeesTable/Employee.vue";
import EmployeesTable from "./components/Content/EmployeesTable/EmployeesTable.vue";
import AddButton from "./components/Content/AddButton.vue";
import AddModal from "./components/Content/Modals/AddModal.vue";
import Content from "./components/Content/Content.vue";
import App from "./App.vue";

const app = createApp(App);

app.component("employee", Employee);
app.component("employees-table", EmployeesTable);
app.component("add-button", AddButton);
app.component("add-modal", AddModal);
app.component("Content", Content);
app.mount("#app");
