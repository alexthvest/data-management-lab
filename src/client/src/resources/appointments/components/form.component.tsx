import { required, SimpleForm, TextInput } from "react-admin";

export const AppointmentForm = () => (
  <SimpleForm>
    <TextInput source="title" variant="outlined" validate={[required()]} />
  </SimpleForm>
);