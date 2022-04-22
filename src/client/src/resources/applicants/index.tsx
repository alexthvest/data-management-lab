import { Create, Edit } from "react-admin";
import PeopleOutlineIcon from "@mui/icons-material/PeopleOutline";

import { ResourceItem } from "../../common/models";

import { ApplicantList } from "./components/list.component";
import { ApplicantForm } from "./components/form.component";

export const applicantResource: ResourceItem = {
  icon: PeopleOutlineIcon,
  name: "applicants",
  components: {
    list: ApplicantList,
    create: props => <Create {...props}><ApplicantForm /></Create>,
    edit: props => <Edit {...props}><ApplicantForm /></Edit>
  }
};