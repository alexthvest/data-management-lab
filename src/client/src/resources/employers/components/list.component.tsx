import { Datagrid, DeleteButton, EditButton, List, ReferenceField, TextField } from "react-admin";

export const EmployerList = () => (
  <List>
    <Datagrid>
      <TextField source="name" />
      <TextField source="address" />
      <TextField source="phone" />
      <ReferenceField label="Kind of Activity" source="kindOfActivityId" reference="kindofactivities">
        <TextField source="title" />
      </ReferenceField>
      <EditButton />
      <DeleteButton />
    </Datagrid>
  </List>
);