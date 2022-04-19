import { Resource } from "react-admin";

import { ApplicantList } from "./components/list.component";

export const ApplicantResource = () =>
  <Resource name="applicants" list={ApplicantList} />;