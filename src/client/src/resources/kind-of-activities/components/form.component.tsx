import { required, SimpleForm, TextInput } from "react-admin";

export const KindOfActivityForm = () => (
  <SimpleForm>
    <TextInput source="title" variant="outlined" validate={[required()]} />
  </SimpleForm>
);