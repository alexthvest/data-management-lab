import { Datagrid, DeleteButton, EditButton, List, TextField, NumberField, ReferenceField, BooleanField } from "react-admin";

export const VacancyList = () => (
  <List>
    <Datagrid>
      <ReferenceField label="Employer" source="employerId" reference="employers">
        <TextField source="name" />
      </ReferenceField>
       <ReferenceField label="Appointment" source="appointmentId" reference="appointments">
        <TextField source="title" />
      </ReferenceField>
      <NumberField source="salary" />
      <BooleanField source="isOpen" />
      <EditButton />
      <DeleteButton />
    </Datagrid>
  </List>
);
