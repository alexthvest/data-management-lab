import { Datagrid, DeleteButton, EditButton, FunctionField, List } from "react-admin";

export const ApplicantList = () => (
  <List>
    <Datagrid>
      <FunctionField label="Full Name" sortBy="author.first_name"
        render={(r => `${r.lastName} ${r.firstName} ${r.surname ?? ''}`)} />
      <EditButton />
      <DeleteButton />
    </Datagrid>
  </List>
);
