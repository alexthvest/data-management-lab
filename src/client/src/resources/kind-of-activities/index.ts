import InterestsOutlinedIcon from '@mui/icons-material/InterestsOutlined';

import { ResourceItem } from "../../common/models";
import { KindOfActivityList } from "./components/list.component";

export const kindOfActivityResource: ResourceItem = {
  icon: InterestsOutlinedIcon,
  name: "kindofactivities",
  options: {
    label: "Kind of activities"
  },
  components: {
    list: KindOfActivityList,
  }
};