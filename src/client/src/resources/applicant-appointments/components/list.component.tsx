import { Datagrid, DeleteButton, EditButton, List, ReferenceField, TextField, FunctionField } from "react-admin";

export const ApplicantAppointmentList = () => (
  <List>
    <Datagrid>
      <ReferenceField label="Applicant" source="applicantId" reference="applicants">
        <FunctionField render={(r => `${r.lastName} ${r.firstName} ${r.surname ?? ''}`)} />
      </ReferenceField>
      <ReferenceField label="Appointment" source="appointmentId" reference="appointments">
        <TextField source="title" />
      </ReferenceField>
      <EditButton />
      <DeleteButton />
    </Datagrid>
  </List>
);
