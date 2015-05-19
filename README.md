**SafeLess**
------------

does not store passwords, they are calculated on the fly. Individually for each site they are derived from a master password. SHA256 encryption ensures that 'back calculating' the master password is not possible. For comfortable usage site settings are stored optionally.
This is a stable working beta release, anyway install it at your own risk and be sure to note down or save your generated access codes to a second place. I'm looking forward to your reports and suggestions ...

#####`Hovering`
over fields, buttons and check-marks pops up a brief help.

**User**
Enter a username here, so more than one person can use same sites with different logins. At least four letters or digits are required. The font color changes from blue to black if valid.

**Master Password**
From this password all passwords for your sites are derived. At least four letters, digits or special characters are required. The font color changes from blue to black if valid.

**Site**
Enter a sitename here, for example the sites URL or parts of it. At least four letters, digits or special characters are required. While typing already saved sites are suggested. Suggestions can be browsed with cursor up/down and taken over by pressing return. The font color changes from blue to black if a site is already stored.

- Change the digit to the right to get a fresh password for a site
- Save-button saves site
- Delete-button deletes site
- <-button navigates backwards through saved sites
- >-button navigates forward through saved sites

**Username**
Enter the username for a site here, mostly an eMail address is used. This field is optional.

**Password**
Calculated password for a site.

- Below this field you can change the complexity and length of the password

**CTRL-U/P**
If checked and a password is shown, CTRL-U/P fills in a sites username and password.

- place the cursor on sites username/password field
- press CTRL-U on username
- press CTRL-P on password

**Copyright**
SafeLess uses ISC license.
Thanks to 'Zer' for CryptSharp that uses ISC license.

Copyright (c) 2014, Kurt Schuster, [qrt@qland.de](mailto:qrt@qland.de)
Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.
THE SOFTWARE IS PROVIDED 'AS IS' AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
