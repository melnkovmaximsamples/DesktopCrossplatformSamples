import { useEffect, useState } from "react";
import { useLocation } from "react-router-dom";
import styled from "styled-components";
import { IMessage } from "../../models/IMessage";
import { getAllMessagesAsync } from "../../services/messagesRequestSender";
import Message from "../Message/Message";

const Container = styled.div`
    display: flex;
    flex-direction: column;
    gap: 20px;
`;

const MessageCollection = () => {
    const [messages, setMessages] = useState<IMessage[]>([]);
    const location = useLocation();

    useEffect(() => {
        const fetchData = async () => {
            const messages = await getAllMessagesAsync();

            setMessages(messages);
        };

        fetchData();
    }, []);

    useEffect(() => {
        if (!location.state) return;

        setMessages(location.state as IMessage[]);
    }, location.state);

    return (
        <Container>
            {messages.map((message, index) => (
                <Message key={index} {...message} />
            ))}
        </Container>
    );
};

export default MessageCollection;
