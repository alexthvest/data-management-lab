import { Create, Edit } from "react-admin";
import PeopleOutlineIcon from "@mui/icons-material/PeopleOutline";

import { ResourceItem } from "../../common/models";

import { EmployerList } from "./components/list.component";
import { EmployerForm } from "./components/form.component";

export const employerResource: ResourceItem = {
  icon: PeopleOutlineIcon,
  name: "employers",
  components: {
    list: EmployerList,
    create: props => <Create {...props}><EmployerForm /></Create>,
    edit: props => <Edit {...props}><EmployerForm /></Edit>
  }
};