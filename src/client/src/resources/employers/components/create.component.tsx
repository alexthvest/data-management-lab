import { Create, CreateProps, RaRecord, ReferenceInput, SelectInput, SimpleForm, TextInput } from "react-admin";

export const EmployerCreate = (props: CreateProps<RaRecord>) => (
  <Create {...props}>
    <SimpleForm>
      <TextInput source="name" />
      <TextInput source="address" />
      <TextInput source="phone" />
      <ReferenceInput label="Kind of Activity" source="kindOfActivityId" reference="kindofactivities">
        <SelectInput optionText="title" />
      </ReferenceInput>
    </SimpleForm>
  </Create>
);