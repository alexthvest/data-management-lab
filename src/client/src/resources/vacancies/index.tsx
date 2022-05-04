import { Create, Edit } from 'react-admin';
import InterestsOutlinedIcon from '@mui/icons-material/InterestsOutlined';

import { ResourceItem } from "../../common/models";

import { VacancyList } from "./components/list.component";
import { VacancyForm } from './components/form.component';

export const vacancyResource: ResourceItem = {
  icon: InterestsOutlinedIcon,
  name: "vacancies",
  components: {
    list: VacancyList,
    create: props => <Create {...props}><VacancyForm /></Create>,
    edit: props => <Edit {...props}><VacancyForm /></Edit>
  }
};
