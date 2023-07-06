import { ListGroup } from "react-bootstrap";
import { Link } from "react-router-dom";

function SidePanel() {
  return (
    <ListGroup>
      <ListGroup.Item as={Link} to="communication">
        Communication
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="education">
        education
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="experiance">
        Experiance
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="general">
        General
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="hobby">
        Hobby
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="language">
        Language
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="personalattribute">
        Personal Attribute
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="programmingskill">
        Programming skill
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="project">
        Project
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="socialnetwork">
        Social network
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="user">
        User
      </ListGroup.Item>
    </ListGroup>
  );
}

export default SidePanel;
