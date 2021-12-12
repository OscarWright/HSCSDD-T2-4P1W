# [4 Pics 1 Word](https://github.com/OscarWright/HSCSDD-T2-4P1W) 🖼️ - HSC SDD Task 2.

## Task specifications

4 pics 1 word is a popular puzzle game for mobile devices that contains four pictures with one thing in common. The developer of 4 pics 1 word, LOTUM has enlisted you to develop a desktop version of the game. The game must randomise the pictures and letters, include at least six levels, maximum five guesses per word with a hint after the third attempt and a printable scoreboard.

## Table of Contents

- [Getting Started](#getting-started)
	- [Install](#install)
	- [Desktop usage](#desktop-usage)
	- [Web extension](#web-extension)
- [Requirements](#requirements)
- [Keyboard shortcuts](#keyboard-shortcuts)
- [Contribute](#contribute)
	- [Vulnerability disclosure](#vulnerability-disclosure)
	- [Note on Patches/Pull Requests](#note-on-patchespull-requests)
- [Contribute](#contribute)
	- [Code of Conduct](#code-of-conduct)
- [Copyright](#copyright)

## Getting Started

### Install

You can also host Octobox yourself! See [the installation guide](docs/INSTALLATION.md)
for installation instructions and details regarding deployment to Heroku, Docker, and more.

### Desktop usage

You can run Octobox locally as a desktop app too if you'd like, using [Nativefier](https://www.npmjs.com/package/nativefier):

```bash
npm install -g nativefier
nativefier "https://octobox.io" # Or your own self-hosted URL
```

This will build a local application (.exe, .app, etc) and put it in your current folder, ready to use.

### Web extension

You can also install the cross-browser [Octobox Web Extension](https://github.com/tfrommen/octobox-web-extension). It is available for [Google Chrome](https://chrome.google.com/webstore/detail/octobox-web-extension/efhkcafmbonnomnimilnephjgeccffdn) and [Mozilla Firefox](https://addons.mozilla.org/en-US/firefox/addon/octobox-web-extension/), but you can also use it with other browsers that support web extensions.

## Requirements

[Web notifications](https://github.com/settings/notifications) must be enabled in your GitHub settings for Octobox to work. To receive vulnerability notifications, you must enable them as well.

<img width="739" alt="screenshot 2018-11-12 at 14 32 38" src="/docs/assets/notification-settings.png">

## Viewing comment threads

Octobox's thread view support is currently in public beta. To enable it select 'on octobox' from the 'Open notifications' menu in `/settings`.

Threads need to be synchronised in order to view them in Octobox. Some notifications will still show the `:link-external:` icon from the notification window if they do not have an associated thread or have yet to synchronise one.

## Keyboard shortcuts

You can use keyboard shortcuts to navigate and perform certain actions:

 - `a` - Select/deselect all
 - `r` or `.` - Refresh list
 - `j` - Move down the list
 - `k` - Move up the list
 - `s` - Star current notification
 - `x` - Mark/unmark current notification
 - `y` or `e` - Archive current/marked notification(s)
 - `m` - Mute current/marked notification(s)
 - `d` - Mark current/marked notification(s) as read here and on GitHub
 - `o` or `Enter` - Open current notification in a new window

Press `?` for the help menu.

## Backers
Thank you to all our backers! 🙏 [[Become a backer](https://opencollective.com/octobox#backer)]

<a href="https://opencollective.com/octobox#backers" target="_blank"><img src="https://opencollective.com/octobox/backers.svg?width=890"></a>

## Sponsors

Support this project by becoming a sponsor. Your logo will show up here with a link to your website. [[Become a sponsor](https://opencollective.com/octobox#sponsor)]

<a href="https://opencollective.com/octobox/sponsor/0/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/0/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/1/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/1/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/2/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/2/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/3/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/3/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/4/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/4/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/5/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/5/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/6/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/6/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/7/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/7/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/8/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/8/avatar.svg"></a>
<a href="https://opencollective.com/octobox/sponsor/9/website" target="_blank"><img src="https://opencollective.com/octobox/sponsor/9/avatar.svg"></a>

## Contribute

Please do! The source code is hosted at [GitHub](https://github.com/octobox/octobox). If you want something, [open an issue](https://github.com/octobox/octobox/issues/new) or a pull request.

If you need want to contribute but don't know where to start, take a look at the issues tagged as ["Help Wanted"](https://github.com/octobox/octobox/issues?q=is%3Aopen+is%3Aissue+label%3A%22help+wanted%22).

You can also help triage issues. This can include reproducing bug reports, or asking for vital information such as version numbers or reproduction instructions. If you would like to start triaging issues, one easy way to get started is to [subscribe to Octobox on CodeTriage](https://www.codetriage.com/octobox/octobox).

Finally, this is an open source project. If you would like to become a maintainer, we will consider adding you if you contribute frequently to the project. Feel free to ask.

For other updates, follow the project on Twitter: [@octoboxio](https://twitter.com/octoboxio).

### Note on Patches/Pull Requests

 * Fork the project.
 * Make your feature addition or bug fix.
 * Add tests for it. This is important so we don't break it in a future version unintentionally.
 * Send a pull request. Bonus points for topic branches.

### Vulnerability disclosure

We support and encourage security research on Octobox under the terms of our [vulnerability disclosure policy](docs/VULNERABILITY_DISCLOSURE_POLICY.md).

### Code of Conduct

Please note that this project is released with a [Contributor Code of Conduct](docs/CODE_OF_CONDUCT.md). By participating in this project you agree to abide by its terms.

## Copyright

[GNU Affero License](LICENSE.txt) © 2021 [Andrew Nesbitt](https://github.com/andrew).
