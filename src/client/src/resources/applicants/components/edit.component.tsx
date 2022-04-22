import { Edit, EditProps, RaRecord, SimpleForm, TextInput, required } from "react-admin";
import { RichTextInput } from "ra-input-rich-text";

export const ApplicantEdit = (props: EditProps<RaRecord>) => (
  <Edit {...props}>
    <SimpleForm>
      <TextInput source="firstName" variant="outlined" validate={[required()]} />
      <TextInput source="lastName" variant="outlined" validate={[required()]} />
      <TextInput source="surname" variant="outlined" />
      <RichTextInput source="otherData" />
    </SimpleForm>
  </Edit>
);