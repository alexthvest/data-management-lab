import { AutocompleteInput, ReferenceInput, SimpleForm, TextInput, required } from "react-admin";

export const EmployerForm = () => (
  <SimpleForm>
    <TextInput source="name" variant="outlined" validate={[required()]} />
    <TextInput source="address" variant="outlined" validate={[required()]} />
    <TextInput source="phone" variant="outlined" validate={[required()]} />
    <ReferenceInput label="Kind of Activity" source="kindOfActivityId" reference="kindofactivities">
      <AutocompleteInput optionText="title" variant="outlined" validate={[required()]} />
    </ReferenceInput>
  </SimpleForm>
);