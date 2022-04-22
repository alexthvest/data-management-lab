import { Datagrid, DeleteButton, EditButton, List, TextField } from "react-admin";

export const KindOfActivityList = () => (
  <List>
    <Datagrid>
      <TextField source="title" />
      <EditButton />
      <DeleteButton />
    </Datagrid>
  </List>
);