<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegFrame1.aspx.cs" Inherits="RegFrame1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
        Employer Registration
    </h1>
    <p>
        To register, complete the fields below.</p>
    <p>
        If you already have been assigned a CareerFCIS.com ID and password, log in to your
        <a href="login.aspx?type='employers'"><b><span style="color: #0000ff">
            Member Desktop</span></b></a> to begin.</p>
    <h3>
        <asp:Label ID="Label1" runat="server"></asp:Label>&nbsp;</h3>
    <h3>
        Member Name&nbsp;<a href="http://www.careersite.com/employer/helpemployerregistration"
            onclick="javascript:popup(this.href, 350, 450, 'MemberName');return false;" tabindex="3001"></a>
    </h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456">
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="10" /></td>
            <td align="left" colspan="4">
                <span class="tablenote"><span class="mandatory" style="color: red">*= required field
                </span></span>
            </td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
                <img height="5" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span style="color: #000000"><span class="tabletitle"><span class="mandatory">First
                    Name<em><span style="font-size: 7pt; color: #ff0000">*</span></em> </span></span>
                    <br />
                    <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><em><span
                        style="font-size: 7pt; color: #ff0000"></span></em></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td style="color: #000000" width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span style="color: #000000"><span class="tabletitle"><span class="mandatory">Last Name
                    <em><span style="color: #ff0000">*</span></em></span></span><br />
                    <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" id="IMG1" /></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td style="color: #000000" width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox2" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span class="tabletitle" style="color: #000000">Title</span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox3" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Company Name</span><span
                    style="color: #000000">&nbsp; &nbsp;</span><a href="http://www.careersite.com/employer/helpemployerregistration"
                        onclick="javascript:popup(this.href, 350, 450, 'CompanyName');return false;"
                        tabindex="3001"></a></span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox4" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
    </table>
    <h3>
        Address&nbsp;<a href="http://www.careersite.com/employer/helpemployerregistration" onclick="javascript:popup(this.href, 350, 450, 'Address');return false;"
            tabindex="3016"></a>
    </h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456">
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10" style="height: 21px">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110" style="height: 21px">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span style="color: #000000"><span class="tabletitle"><span class="mandatory">Address
                </span></span>
                    <br />
                    <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000; height: 21px;" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td style="color: #000000; height: 21px;" width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000; height: 21px;" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox5" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory" style="color: #000000">&nbsp;</span></span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox7" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">City</span></span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox6" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Country</span></span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                <select id="Country" name="country">
                    <option selected="selected" value="USA">USA</option>
                    <option value="Albania">Albania</option>
                    <option value="Algeria">Algeria</option>
                    <option value="American Samoa">American Samoa</option>
                    <option value="Andorra">Andorra</option>
                    <option value="Angola">Angola</option>
                    <option value="Anguilla">Anguilla</option>
                    <option value="Antarctica">Antarctica</option>
                    <option value="Antigua">Antigua</option>
                    <option value="Argentina">Argentina</option>
                    <option value="Armenia">Armenia</option>
                    <option value="Aruba">Aruba</option>
                    <option value="Ascension Island">Ascension Island</option>
                    <option value="Australia">Australia</option>
                    <option value="Austria">Austria</option>
                    <option value="Azerbaijan">Azerbaijan</option>
                    <option value="Bahamas">Bahamas</option>
                    <option value="Bahrain">Bahrain</option>
                    <option value="Bangladesh">Bangladesh</option>
                    <option value="Belarus">Belarus</option>
                    <option value="Belgium">Belgium</option>
                    <option value="Belize">Belize</option>
                    <option value="Benin">Benin</option>
                    <option value="Bermuda">Bermuda</option>
                    <option value="Bhutan">Bhutan</option>
                    <option value="Bolivia">Bolivia</option>
                    <option value="Botswana">Botswana</option>
                    <option value="Brazil">Brazil</option>
                    <option value="British Virgin Islands">British Virgin Islands</option>
                    <option value="Brunei">Brunei</option>
                    <option value="Bulgaria">Bulgaria</option>
                    <option value="Burkina Faso">Burkina Faso</option>
                    <option value="Burma (Myanmar)">Burma (Myanmar)</option>
                    <option value="Cambodia">Cambodia</option>
                    <option value="Cameroon">Cameroon</option>
                    <option value="Canada">Canada</option>
                    <option value="Cape Verde Island">Cape Verde Island</option>
                    <option value="Cayman Islands">Cayman Islands</option>
                    <option value="Central African Republic">Central African Republic</option>
                    <option value="Chad">Chad</option>
                    <option value="Chile">Chile</option>
                    <option value="China">China</option>
                    <option value="Christmas Island">Christmas Island</option>
                    <option value="Cocos Island">Cocos Island</option>
                    <option value="Colombia">Colombia</option>
                    <option value="Congo">Congo</option>
                    <option value="Cook Islands">Cook Islands</option>
                    <option value="Costa Rica">Costa Rica</option>
                    <option value="Croatia">Croatia</option>
                    <option value="Cyprus">Cyprus</option>
                    <option value="Czech Republic">Czech Republic</option>
                    <option value="Denmark">Denmark</option>
                    <option value="Diego Garcia">Diego Garcia</option>
                    <option value="Djibouti">Djibouti</option>
                    <option value="Dominica">Dominica</option>
                    <option value="Dominican Republic">Dominican Republic</option>
                    <option value="Ecuador">Ecuador</option>
                    <option value="Egypt">Egypt</option>
                    <option value="El Salvador">El Salvador</option>
                    <option value="Equatorial Guinea">Equatorial Guinea</option>
                    <option value="Eritrea">Eritrea</option>
                    <option value="Estonia">Estonia</option>
                    <option value="Falkland Islands">Falkland Islands</option>
                    <option value="Faroe Islands">Faroe Islands</option>
                    <option value="Fiji Islands">Fiji Islands</option>
                    <option value="Finland">Finland</option>
                    <option value="France">France</option>
                    <option value="French Antilles">French Antilles</option>
                    <option value="French Guinea">French Guinea</option>
                    <option value="French Polynesia">French Polynesia</option>
                    <option value="Gabon">Gabon</option>
                    <option value="Gambia">Gambia</option>
                    <option value="Georgia">Georgia</option>
                    <option value="Germany">Germany</option>
                    <option value="Ghana">Ghana</option>
                    <option value="Greece">Greece</option>
                    <option value="Greenland">Greenland</option>
                    <option value="Grenada">Grenada</option>
                    <option value="Guam">Guam</option>
                    <option value="Guantanamo Bay">Guantanamo Bay</option>
                    <option value="Guatemala">Guatemala</option>
                    <option value="Guinea-Bissau">Guinea-Bissau</option>
                    <option value="Guinea (PRP)">Guinea (PRP)</option>
                    <option value="Guyana">Guyana</option>
                    <option value="Haiti">Haiti</option>
                    <option value="Honduras">Honduras</option>
                    <option value="Hong Kong">Hong Kong</option>
                    <option value="Hungary">Hungary</option>
                    <option value="Iceland">Iceland</option>
                    <option value="India">India</option>
                    <option value="Indonesia">Indonesia</option>
                    <option value="Iran">Iran</option>
                    <option value="Iraq">Iraq</option>
                    <option value="Ireland">Ireland</option>
                    <option value="Israel">Israel</option>
                    <option value="Italy">Italy</option>
                    <option value="Ivory Coast">Ivory Coast</option>
                    <option value="Jamaica">Jamaica</option>
                    <option value="Japan">Japan</option>
                    <option value="Jordan">Jordan</option>
                    <option value="Kenya">Kenya</option>
                    <option value="Kiribati">Kiribati</option>
                    <option value="Korea (South)">Korea (South)</option>
                    <option value="Kuwait">Kuwait</option>
                    <option value="Kyrgyzstan">Kyrgyzstan</option>
                    <option value="Laos">Laos</option>
                    <option value="Latvia">Latvia</option>
                    <option value="Lebanon">Lebanon</option>
                    <option value="Lesotho">Lesotho</option>
                    <option value="Liberia">Liberia</option>
                    <option value="Libya">Libya</option>
                    <option value="Liechtenstein">Liechtenstein</option>
                    <option value="Lithuania">Lithuania</option>
                    <option value="Luxembourg">Luxembourg</option>
                    <option value="Macedonia">Macedonia</option>
                    <option value="Madagascar">Madagascar</option>
                    <option value="Malawi">Malawi</option>
                    <option value="Malaysia">Malaysia</option>
                    <option value="Maldives">Maldives</option>
                    <option value="Mali Republic">Mali Republic</option>
                    <option value="Malta">Malta</option>
                    <option value="Marshall Islands">Marshall Islands</option>
                    <option value="Mauritania">Mauritania</option>
                    <option value="Mauritius">Mauritius</option>
                    <option value="Mayotte Island">Mayotte Island</option>
                    <option value="Mexico">Mexico</option>
                    <option value="Micronesia">Micronesia</option>
                    <option value="Moldova">Moldova</option>
                    <option value="Monaco">Monaco</option>
                    <option value="Mongolia">Mongolia</option>
                    <option value="Montserrat">Montserrat</option>
                    <option value="Morocco">Morocco</option>
                    <option value="Mozambique">Mozambique</option>
                    <option value="Myanmar">Myanmar</option>
                    <option value="Namibia">Namibia</option>
                    <option value="Nauru">Nauru</option>
                    <option value="Nepal">Nepal</option>
                    <option value="Netherlands">Netherlands</option>
                    <option value="Neth. Antilles">Neth. Antilles</option>
                    <option value="Nevis">Nevis</option>
                    <option value="New Caledonia">New Caledonia</option>
                    <option value="New Zealand">New Zealand</option>
                    <option value="Nicaragua">Nicaragua</option>
                    <option value="Niger">Niger</option>
                    <option value="Nigeria">Nigeria</option>
                    <option value="Niue">Niue</option>
                    <option value="Norfolk Island">Norfolk Island</option>
                    <option value="Norway">Norway</option>
                    <option value="Oman">Oman</option>
                    <option value="Pakistan">Pakistan</option>
                    <option value="Palau">Palau</option>
                    <option value="Panama">Panama</option>
                    <option value="Papa New Guinea">Papa New Guinea</option>
                    <option value="Paraguay">Paraguay</option>
                    <option value="Peru">Peru</option>
                    <option value="Poland">Poland</option>
                    <option value="Portugal">Portugal</option>
                    <option value="Qatar">Qatar</option>
                    <option value="Reunion Island">Reunion Island</option>
                    <option value="Romania">Romania</option>
                    <option value="Russia">Russia</option>
                    <option value="Rwanda">Rwanda</option>
                    <option value="St. Helena">St. Helena</option>
                    <option value="Saudi Arabia">Saudi Arabia</option>
                    <option value="St. Kitts">St. Kitts</option>
                    <option value="St. Lucia">St. Lucia</option>
                    <option value="St. Pierre & Miqu">St. Pierre &amp; Miqu</option>
                    <option value="St. Vincent & Gre">St. Vincent &amp; Gre</option>
                    <option value="Saipan">Saipan</option>
                    <option value="San Marino">San Marino</option>
                    <option value="S�o Tom�">S�o Tom�</option>
                    <option value="Senegal">Senegal</option>
                    <option value="Seychelles Island">Seychelles Island</option>
                    <option value="Sierra Leone">Sierra Leone</option>
                    <option value="Singapore">Singapore</option>
                    <option value="Slovakia">Slovakia</option>
                    <option value="Solomon Islands">Solomon Islands</option>
                    <option value="South Africa">South Africa</option>
                    <option value="Spain">Spain</option>
                    <option value="Sri Lanka">Sri Lanka</option>
                    <option value="Sudan">Sudan</option>
                    <option value="Suriname">Suriname</option>
                    <option value="Sweden">Sweden</option>
                    <option value="Switzerland">Switzerland</option>
                    <option value="Syria">Syria</option>
                    <option value="Taiwan">Taiwan</option>
                    <option value="Tajikistan">Tajikistan</option>
                    <option value="Tanzania">Tanzania</option>
                    <option value="Thailand">Thailand</option>
                    <option value="Togo">Togo</option>
                    <option value="Tonga Islands">Tonga Islands</option>
                    <option value="Trinidad & Tobago">Trinidad &amp; Tobago</option>
                    <option value="Tunisia">Tunisia</option>
                    <option value="Turkey">Turkey</option>
                    <option value="Turkmenistan">Turkmenistan</option>
                    <option value="Tuvalu">Tuvalu</option>
                    <option value="Uganda">Uganda</option>
                    <option value="Ukraine">Ukraine</option>
                    <option value="United Arab Emirates">United Arab Emirates</option>
                    <option value="United Kingdom">United Kingdom</option>
                    <option value="Uruguay">Uruguay</option>
                    <option value="Uzbekistan">Uzbekistan</option>
                    <option value="Vanuatu">Vanuatu</option>
                    <option value="Vatican City">Vatican City</option>
                    <option value="Venezuela">Venezuela</option>
                    <option value="Vietnam">Vietnam</option>
                    <option value="Wallis and Futuna">Wallis and Futuna</option>
                    <option value="Western Samoa">Western Samoa</option>
                    <option value="Yugoslavia">Yugoslavia</option>
                    <option value="Zaire">Zaire</option>
                    <option value="Zambia">Zambia</option>
                    <option value="Zimbabwe">Zimbabwe</option>
                </select>
                &nbsp;<br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Egypt</asp:ListItem>
                    <asp:ListItem>Saudi</asp:ListItem>
                    <asp:ListItem>Qatar</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                    <asp:ListItem>UAE</asp:ListItem>
                </asp:DropDownList>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
    </table>
    <h3>
        Contact Info&nbsp;<a href="http://www.careersite.com/employer/helpemployerregistration"
            onclick="javascript:popup(this.href, 350, 450, 'ContactInfo');return false;"
            tabindex="3017"></a>
    </h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456">
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Phone</span></span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox8" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory"><span style="text-transform: capitalize;
                    color: #000000">email</span><span style="color: #000000"> for Account Communications<em><span
                        style="font-size: 7pt; color: #ff0000">*</span></em></span></span></span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox9" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox9"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span class="tabletitle" style="color: #000000">Website</span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox10" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
    </table>
    <table border="0" cellpadding="0" cellspacing="0" width="456">
        <br />
        <h3>
            Your Account</h3>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory"><span style="color: #000000">User ID<em><span
                    style="font-size: 7pt; color: #ff0000">*</span></em></span><a
                    href="http://www.careersite.com/employer/helpemployerregistration" onclick="javascript:popup(this.href, 350, 450, 'UserID');return false;"
                    tabindex="3002"></a></span></span>
                <br />
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                &nbsp;<br />
                &nbsp;<asp:TextBox ID="TextBox11" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox11"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Password</span><a
                    href="http://www.careersite.com/employer/helpemployerregistration" onclick="javascript:popup(this.href, 350, 450, 'Password');return false;"
                    tabindex="3004"></a><em><span style="font-size: 7pt; color: #ff0000">*</span></em></span>
                <div class="tablenote">
                    <span class="mandatory"></span>
                </div>
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                <img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" />
                <asp:TextBox ID="TextBox12" runat="server" Width="233px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox12"
                    ErrorMessage="Required"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox12"
                    ControlToValidate="TextBox13" ErrorMessage="Passwords Must Match"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /><br />
                <img height="5" src="http://static.prod-b.careersite.com/base/images/red.gif" width="5" /><img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /><br />
                <span style="color: #000000"><span class="tablenote"><span class="mandatory">Re-enter
                    Password<span style="font-size: 7pt; color: #ff0000">*</span><br />
                </span></span>
                    <br />
                    <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="110" /></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="1" /></td>
            <td style="color: #000000" width="5">
                <img height="10" src="http://static.prod-b.careersite.com/base/images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <img height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /><br />
                <img
                    height="2" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" />
                <asp:TextBox ID="TextBox13" runat="server" Width="233px" TextMode="Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox13"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="http://static.prod-b.careersite.com/base/images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" colspan="6">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="4">
                <span style="font-size: 7pt; color: #000066"><strong>
                <asp:CheckBox ID="CheckBox1" runat="server" Height="5px" OnCheckedChanged="CheckBox1_CheckedChanged" Text=" " AutoPostBack="True" />&nbsp;
                    
                </td>
        </tr>
        <tr>
            <td colspan="5" height="3">
                <img height="3" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td colspan="5" height="3">
                <img height="3" src="http://static.prod-b.careersite.com/base/images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td align="middle" colspan="5" style="height: 12px">
                <span class="tabletext">

                    &nbsp; &nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                    <input type="reset" name="Clear" value="Clear Form" /></span></td>
        </tr>
    </table>
    </form>
</body>
</html>
