import { useEffect, useState } from "react";
import { IMessage } from "../../models/IMessage";
import Message from "../Message/Message";

const MessageCollection = () => {
    const [messages, setMessages] = useState<IMessage[]>([]);

    useEffect(() => {

    });

    return (
        <>
            {messages.forEach(message => {
                <Message {...message} />
            })}
        </>
    )
};

export default MessageCollection;