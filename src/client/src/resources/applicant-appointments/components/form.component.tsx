import { required, SimpleForm, TextInput } from "react-admin";
import { RichTextInput } from "ra-input-rich-text";

export const ApplicantAppointmentForm = () => (
  <SimpleForm>
    <TextInput source="firstName" variant="outlined" validate={[required()]} />
    <TextInput source="lastName" variant="outlined" validate={[required()]} />
    <TextInput source="surname" variant="outlined" />
    <RichTextInput source="otherData" />
  </SimpleForm>
);
