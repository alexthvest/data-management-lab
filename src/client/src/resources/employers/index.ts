import PeopleOutlineIcon from "@mui/icons-material/PeopleOutline";

import { ResourceItem } from "../../common/models";

import { EmployerList } from "./components/list.component";
import { EmployerCreate } from "./components/create.component";
import { EmployerEdit } from "./components/edit.component";

export const employerResource: ResourceItem = {
  icon: PeopleOutlineIcon,
  name: "employers",
  components: {
    list: EmployerList,
    create: EmployerCreate,
    edit: EmployerEdit
  }
};