import { Datagrid, DeleteButton, EditButton, List, TextField, NumberField, ReferenceField, FunctionField } from "react-admin";

export const DealList = () => (
  <List>
    <Datagrid>
      <ReferenceField label="Vacancy" source="vacancyId" reference="vacancies">
        <TextField source="id" />
      </ReferenceField>
      <ReferenceField label="Applicant" source="applicantId" reference="applicants">
        <FunctionField render={(r => `${r.lastName} ${r.firstName} ${r.surname ?? ''}`)} />
      </ReferenceField>
      <NumberField source="salary" />
      <NumberField source="commission" />
      <EditButton />
      <DeleteButton />
    </Datagrid>
  </List>
);
