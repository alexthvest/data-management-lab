import WorkOutlineIcon from '@mui/icons-material/WorkOutline';

import { ResourceItem } from "../../common/models";
import { AppointmentList } from "./components/list.component";

export const appointmentResource: ResourceItem = {
  icon: WorkOutlineIcon,
  name: "appointments",
  components: {
    list: AppointmentList,
  }
};