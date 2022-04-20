import { Datagrid, List, TextField } from "react-admin";

export const KindOfActivityList = () => (
  <List>
    <Datagrid>
      <TextField source="title" />
    </Datagrid>
  </List>
);