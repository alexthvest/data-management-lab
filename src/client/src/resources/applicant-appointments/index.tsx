import { Create, Edit } from "react-admin";
import PeopleOutlineIcon from "@mui/icons-material/PeopleOutline";

import { ResourceItem } from "../../common/models";

import { ApplicantAppointmentList } from "./components/list.component";
import { ApplicantAppointmentForm } from "./components/form.component";

export const applicantAppointmentResource: ResourceItem = {
  icon: PeopleOutlineIcon,
  name: "applicantappointments",
  options: {
    label: "Applicants - Appointments"
  },
  components: {
    list: ApplicantAppointmentList,
    create: props => <Create {...props}><ApplicantAppointmentForm /></Create>,
    edit: props => <Edit {...props}><ApplicantAppointmentForm /></Edit>
  }
};
