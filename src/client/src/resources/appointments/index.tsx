import { Create, Edit } from 'react-admin';
import WorkOutlineIcon from '@mui/icons-material/WorkOutline';

import { ResourceItem } from "../../common/models";
import { AppointmentForm } from './components/form.component';
import { AppointmentList } from "./components/list.component";

export const appointmentResource: ResourceItem = {
  icon: WorkOutlineIcon,
  name: "appointments",
  components: {
    list: AppointmentList,
    create: props => <Create {...props}><AppointmentForm /></Create>,
    edit: props => <Edit {...props}><AppointmentForm /></Edit>
  }
};