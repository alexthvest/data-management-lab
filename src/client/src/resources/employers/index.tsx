import { Resource } from "react-admin";

import { EmployerList } from "./components/list.component";

export const EmployerResource = () =>
  <Resource name="employers" list={EmployerList} />;