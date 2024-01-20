

#region bağımlı örnek
//class MailSender{
//    public void Send()
//    {
//        Gmail gmail = new();
//        gmail.Send();
//    }
//}

//class Gmail
//{
//    public void Send() { 
//        ///
//    }
//}
#endregion

using LooseCoupling.InDependecy;

MailSender sender = new();
sender.Send(new Gmail());
sender.Send(new HotMail());


//burda yazılımcı karar vermemiş oluyoruz. Böyle kullanılmasın doğru bir örnek değildirç
//MailSender sender2 = new();
//sender2.Send();
//sender2.Send();











