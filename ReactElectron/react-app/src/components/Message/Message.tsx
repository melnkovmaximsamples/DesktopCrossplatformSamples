import styled from 'styled-components';
import { IMessage } from '../../models/IMessage';

const Message = (props: IMessage) => {
    const Container = styled.div`
        border: 2px solid black;
        border-radius: 30px;
        padding: 30px;
    `;
    const Label = styled.span`
        display: inline-block;
        width: 70px;
    `
    const Value = styled.span`
        display: inline-block;
        width: 100%;
    `

    return (
        <Container>
            <div>
                <Label>Id</Label>
                <Value>{props.id}</Value>
            </div>
            <div>
                <Label>Author</Label>
                <Value>{props.author}</Value>
            </div>
            <div>
                <Label>Text</Label>
                <Value>{props.text}</Value>
            </div>
        </Container>
    );
}

export default Message;