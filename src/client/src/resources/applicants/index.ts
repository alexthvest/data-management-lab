import PeopleOutlineIcon from "@mui/icons-material/PeopleOutline";

import { ResourceItem } from "../../common/models";

import { ApplicantList } from "./components/list.component";
import { ApplicantCreate } from "./components/create.component";
import { ApplicantEdit } from "./components/edit.component";

export const applicantResource: ResourceItem = {
  icon: PeopleOutlineIcon,
  name: "applicants",
  components: {
    list: ApplicantList,
    create: ApplicantCreate,
    edit: ApplicantEdit
  }
};