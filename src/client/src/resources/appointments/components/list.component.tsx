import { Datagrid, DeleteButton, EditButton, List, TextField } from "react-admin";

export const AppointmentList = () => (
  <List>
    <Datagrid>
      <TextField source="title" />
      <EditButton />
      <DeleteButton />
    </Datagrid>
  </List>
);