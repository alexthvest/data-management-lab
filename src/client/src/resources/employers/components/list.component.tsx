import { Datagrid, List, TextField } from "react-admin";

export const EmployerList = () => (
  <List>
    <Datagrid>
      <TextField source="name" />
      <TextField source="address" />
      <TextField source="phone" />
    </Datagrid>
  </List>
);