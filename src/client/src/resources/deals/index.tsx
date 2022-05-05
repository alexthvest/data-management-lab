import { Create, Edit } from 'react-admin';
import WorkOutlineIcon from '@mui/icons-material/WorkOutline';

import { ResourceItem } from "../../common/models";

import { DealList } from "./components/list.component";
import { DealForm } from './components/form.component';

export const dealResource: ResourceItem = {
  icon: WorkOutlineIcon,
  name: "deals",
  components: {
    list: DealList,
    create: props => <Create {...props}><DealForm /></Create>,
    edit: props => <Edit {...props}><DealForm /></Edit>
  }
};
