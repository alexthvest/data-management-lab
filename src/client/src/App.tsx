import React from "react";
import { Admin, Resource } from "react-admin";

import restProvider from "ra-data-simple-rest";

import { EmployerList } from "./resources/employers/components/list.component";
import { ApplicantList } from "./resources/applicants/components/list.component";
import { KindOfActivityList } from "./resources/kind-of-activity/components/list.component";

const dataProvider = restProvider("api");

export const App: React.FC = () => {
  return (
    <Admin dataProvider={dataProvider}>
      <Resource name="employers" list={EmployerList} />
      <Resource name="applicants" list={ApplicantList} />
      <Resource name="kindofactivities" list={KindOfActivityList} />
    </Admin>
  );
};
