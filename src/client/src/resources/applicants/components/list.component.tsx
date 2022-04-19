import { Datagrid, List, TextField } from "react-admin";

export const ApplicantList = () => (
  <List>
    <Datagrid>
      <TextField source="firstName" />
      <TextField source="lastName" />
      <TextField source="surname" />
      <TextField source="otherData" />
    </Datagrid>
  </List>
);