import { Create, Edit } from 'react-admin';
import InterestsOutlinedIcon from '@mui/icons-material/InterestsOutlined';

import { ResourceItem } from "../../common/models";

import { KindOfActivityList } from "./components/list.component";
import { KindOfActivityForm } from './components/form.component';

export const kindOfActivityResource: ResourceItem = {
  icon: InterestsOutlinedIcon,
  name: "kindofactivities",
  options: {
    label: "Kind of activities"
  },
  components: {
    list: KindOfActivityList,
    create: props => <Create {...props}><KindOfActivityForm /></Create>,
    edit: props => <Edit {...props}><KindOfActivityForm /></Edit>
  }
};