import React from "react";
import { Admin } from "react-admin";

import restProvider from "ra-data-simple-rest";

import { EmployerResource } from "./resources/employers";
import { ApplicantResource } from "./resources/applicants";

const dataProvider = restProvider("api");

export const App: React.FC = () => {
  return (
    <Admin dataProvider={dataProvider}>
      <EmployerResource />
      <ApplicantResource />
    </Admin>
  );
};
