import styled from "styled-components";
import { IMessage } from "../../models/IMessage";

const Container = styled.div`
    border: 2px solid black;
    border-radius: 30px;
    padding: 30px;
`;
const Label = styled.span`
    display: inline-block;
    width: 70px;
`;
const Value = styled.span`
    width: 100%;
`;

const Message = (props: IMessage) => {
    return (
        <Container>
            <p>
                <Label>Id</Label>
                <Value>{props.id}</Value>
            </p>
            <p>
                <Label>Author</Label>
                <Value>{props.author}</Value>
            </p>
            <p>
                <Label>Text</Label>
                <Value>{props.text}</Value>
            </p>
        </Container>
    );
};

export default Message;
