import React from "react";
import { Admin, Resource } from "react-admin";

import restProvider from "ra-data-simple-rest";

import { EmployerList, EmployerCreate, EmployerEdit } from "./resources/employers";
import { ApplicantList, ApplicantCreate, ApplicantEdit } from "./resources/applicants";
import { KindOfActivityList } from "./resources/kind-of-activities";
import { AppointmentList } from "./resources/appointments";

import PeopleIcon from "@mui/icons-material/PeopleOutline";
import InterestsIcon from '@mui/icons-material/InterestsOutlined';
import WorkOutlineIcon from '@mui/icons-material/WorkOutline';

const dataProvider = restProvider("api");

export const App: React.FC = () => {
  return (
    <Admin dataProvider={dataProvider}>
      <Resource 
        icon={PeopleIcon} name="employers" 
        list={EmployerList} create={EmployerCreate} edit={EmployerEdit} />

      <Resource 
        icon={PeopleIcon}name="applicants" 
        list={ApplicantList} create={ApplicantCreate} edit={ApplicantEdit} />

      <Resource 
        icon={InterestsIcon} name="kindofactivities" 
        options={{ label: "Kind of Activities" }} 
        list={KindOfActivityList} />

      <Resource 
        icon={WorkOutlineIcon} name="appointments" 
        list={AppointmentList} />
    </Admin>
  );
};
